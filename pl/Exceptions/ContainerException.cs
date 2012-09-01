// -----------------------------------------------------------------------
// <copyright file="ContainerException.cs" company="Humilis">
// David Harper 2012, this is free software.
// </copyright>
// -----------------------------------------------------------------------

namespace pl.Exceptions
{
    using System;

    /// <summary>
    /// An exception thrown by the Ioc Container.
    /// </summary>
    public class ContainerException : SystemException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerException" /> class.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="args">Optional error message arguments.</param>
        public ContainerException(string message, params object[] args)
            : base(string.Format(message, args))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        public ContainerException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
