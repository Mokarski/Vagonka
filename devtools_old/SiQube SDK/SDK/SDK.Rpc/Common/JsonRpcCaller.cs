using System;
using System.IO;
using Jayrock.Json;
using SDK.Interfaces;

namespace SDK.Rpc.Common
{
    internal static class JsonRpcCaller
    {
        /// <summary>
        /// Запрос на выполнение json-rpc метода
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="returnType"></param>
        /// <param name="id"></param>
        /// <param name="method"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        /// <exception cref="JsonException">ошибочный ответ при приравнивание к типу</exception>
        public static object Invoke(Stream stream, Type returnType, long id, string method, object args)
        {
            if (method == null)
                throw new ArgumentNullException("method");
            if (method.Length == 0)
                throw new ArgumentException(null, "method");

            return Invoke(stream, returnType, new JsonRequest(id, method, args));
        }

        /// <summary>
        /// Запрос на выполнение json-rpc метода
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="returnType"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="JsonException">ошибочный ответ при приравнивание к типу</exception>
        public static object Invoke(Stream stream, Type returnType, IJsonRequest request)
        {
            if (returnType == null)
                throw new ArgumentNullException("returnType");
            if (stream == null)
                throw new ArgumentNullException("stream");
            if (request == null)
                throw new ArgumentNullException("request");

            var streamer = new Streamer(stream);

            // send request
            streamer.WriteLine(request.ToString());

            // get response
            var response = streamer.ReadLine(TimeSpan.MaxValue);
            while (response == "")
            {
                response = streamer.ReadLine(TimeSpan.MaxValue);
            }

            return (new ResponseParser(response, returnType)).Result();
        }
    }
}