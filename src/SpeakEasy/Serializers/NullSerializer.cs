using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace SpeakEasy.Serializers
{
    public class NullSerializer : ISerializer
    {
        private readonly string contentType;

        public NullSerializer(string contentType)
        {
            this.contentType = contentType;
        }

        public string MediaType => throw new NotImplementedException();

        public IEnumerable<string> SupportedMediaTypes => new string[0];

        public Task SerializeAsync<T>(Stream stream, T body, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public T Deserialize<T>(Stream body)
        {
            throw BuildNotSupportedException();
        }

        public object Deserialize(Stream body, Type type)
        {
            throw BuildNotSupportedException();
        }

        private NotSupportedException BuildNotSupportedException()
        {
            return new NotSupportedException($"Could not find a deserializer that supports the content type {contentType}");
        }
    }
}
