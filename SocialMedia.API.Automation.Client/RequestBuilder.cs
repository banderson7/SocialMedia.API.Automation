using System.Collections.Generic;
using RestSharp;
using SocialMedia.API.Automaiton.Common;

namespace SocialMedia.API.Automation.Client
{
    public class RequestBuilder
    {
        private readonly string resource;
        private readonly Dictionary<string, string> headers;
        private readonly List<Parameter> parameters;
        private DataFormat dataFormat;
        private Method method;
        private string body;

        public RequestBuilder(string resource)
        {
            this.resource = resource;
            headers = new Dictionary<string, string>();
            parameters = new List<Parameter>();
            method = Method.GET;
            dataFormat = DataFormat.Json;
            body = null;
        }
        public RequestBuilder(string resource, Method method)
        {
            this.resource = resource;
            headers = new Dictionary<string, string>();
            parameters = new List<Parameter>();
            this.method = method;
            dataFormat = DataFormat.Json;
            body = null;
        }

        public RequestBuilder AddHeader(string name, string value)
        {
            if (!headers.ContainsKey(name))
            {
                headers.Add(name, value);
            }
            return this;
        }

        public RequestBuilder AddBody(string body)
        {
            this.body = body;
            return this;
        }

        public RequestBuilder SetMethod(Method method)
        {
            this.method = method;
            return this;
        }

        public RequestBuilder AddParameter (Parameter parameter)
        {
            if (!parameters.Contains(parameter))
            {
                parameters.Add(parameter);
            }
            return this;
        }

        public IRestRequest Create()
        {
            var request = new RestRequest(StringConstants.BasePath + resource, method, dataFormat);

            foreach (var param in parameters)
            {
                request.Parameters.Add(param);
            }
            request.AddHeaders(headers);
            if (body != null)
            {
                request.AddJsonBody(body);
            }

            return request;
        }
    }
}
