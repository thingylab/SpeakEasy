using SpeakEasy.Contents;

namespace SpeakEasy.Bodies
{
    internal class NullRequestBody : IRequestBody
    {
        public bool ConsumesResourceParameters { get; } = false;

        public IContent Serialize(ITransmissionSettings transmissionSettings, IArrayFormatter arrayFormatter)
        {
            return new NullContent(transmissionSettings);
        }
    }
}
