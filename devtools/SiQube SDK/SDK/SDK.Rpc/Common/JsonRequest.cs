using System;
using Jayrock.Json;
using Jayrock.Json.Conversion;
using SDK.Interfaces;

namespace SDK.Rpc.Common
{
    public class JsonRequest : IJsonRequest
    {
        private readonly string mRequest;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <exception cref="ArgumentNullException">строка запроса не может быть равна null</exception>
        /// <exception cref="ArgumentException">json request некорректен по формату</exception>
        public JsonRequest(string request)
        {
            if (request == null)
                throw new ArgumentNullException("request");
            if (request.Length == 0)
                throw new ArgumentException(null, "request");

            mRequest = request;
            Args = null;

            // parse request here
            var reader = JsonText.CreateReader(mRequest);
            var members = JsonBuffer.From(reader).GetMembersArray();
            foreach (var member in members)
            {

                switch (member.Name)
                {
                    case "id":
                        Id = (long)JsonConvert.Import(typeof(long), member.Buffer.CreateReader());
                        break;
                    case "method":
                        Method = (string)JsonConvert.Import(typeof(string), member.Buffer.CreateReader());
                        break;
                    case "params":
                        Args = JsonConvert.Import(typeof(object), member.Buffer.CreateReader());
                        break;
                }
            }

            if (Method.Length == 0)
                throw new ArgumentException("method");
        }

        public JsonRequest(long id, string method, object args)
        {
            if (method == null)
                throw new ArgumentNullException("method");
            if (method.Length == 0)
                throw new ArgumentException(null, "method");

            Id = id;
            Method = method;
            Args = args;

            var call = new JsonObject();
            call["id"] = id;
            call["method"] = method;
            if (args != null)
                call["params"] = args;

            mRequest = JsonConvert.ExportToString(call);
        }

        /// <summary>
        /// raw json rpc request
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return mRequest;
        }

        public long Id { get; private set; }
        public string Method { get; private set; }
        public object Args { get; private set; }
    }
}