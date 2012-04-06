using System;
using System.Net;

namespace Resticle
{
    /// <summary>
    /// A rest request represents one http interaction with
    /// a restful web service
    /// </summary>
    public interface IRestRequest
    {
        /// <summary>
        /// The url that will be requested by this rest request
        /// </summary>
        Uri Url { get; }

        /// <summary>
        /// Creates a web request corresponding to this rest request
        /// </summary>
        /// <returns>A web request</returns>
        WebRequest BuildWebRequest();
    }
}