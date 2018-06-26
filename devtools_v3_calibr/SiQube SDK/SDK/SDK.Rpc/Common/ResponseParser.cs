using System;
using System.Collections;
using Jayrock.Json;
using Jayrock.Json.Conversion;

namespace SDK.Rpc.Common
{
    public class ResponseParser
    {
        private readonly object mResult;
        private string mErrorMessage;

        public ResponseParser(string response, Type returnType)
        {
            if (returnType == null)
                throw new ArgumentNullException("returnType");
            if (response == null)
                throw new ArgumentNullException("response");
            if (response.Length == 0)
                throw new ArgumentException(null, "response");


            var reader = JsonText.CreateReader(response);
            var resultSpecified = false;
            mResult = null;
            mErrorMessage = null;

            //
            // JSON-RPC 2.0 specification/protocol, states that either error 
            // or result must be present but not both. JSON-RPC 1.0 is less 
            // strict and states that one or the other must be null. There 
            // is an ambiguity however with 1.0 when both result and error 
            // are null. Here, it is treated like a successful null result.
            //

            var members = JsonBuffer.From(reader).GetMembersArray();
            foreach (var member in members)
            {
                switch (member.Name)
                {
                    case "error":
                        {
                            var errorObject = JsonConvert.Import(member.Buffer.CreateReader());
                            if (errorObject != null)
                                OnError(errorObject);
                        }
                        break;

                    case "id":
                        Id = (string)JsonConvert.Import(typeof(string), member.Buffer.CreateReader());
                        break;

                    case "result":
                        {
                            resultSpecified = true;

                            mResult = (returnType != typeof(JsonBuffer))
                                          ? JsonConvert.Import(returnType, member.Buffer.CreateReader())
                                          : response;
                        }
                        break;

                }
            }

            if (!resultSpecified) // never gets here on error
                throw new Exception("Invalid JSON-RPC response. It contains neither a result nor an error.");
        }

        public string Id { get; private set; }

        public object Result()
        {
            return mResult;
        }

        public string Error()
        {
            return mErrorMessage;
        }

        private void OnError(object errorObject)
        {
            var error = errorObject as IDictionary;

            if (error != null)
            {
                mErrorMessage = error["message"] as string;
                //throw new Exception(error["message"] as string);
            }

            mErrorMessage = (errorObject as string);
            //throw new Exception(errorObject as string);
        }
    }
}