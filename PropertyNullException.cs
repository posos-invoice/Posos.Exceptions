﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Posos.Exceptions
{
    /// <summary>
    /// The exception that is thrown when a null reference (<b>Nothing</b> in Visual Basic) is set on a property that does not accept it as a valid value.
    /// </summary>
    public class PropertyNullException : PropertyException 
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the PropertyNullException class.
        /// </summary>
        public PropertyNullException() : base(Resources.Resources.ResourceManager.GetString("Prop_PropertyNull"))
        {
        }

        /// <summary>
        /// Initializes a new instance of the PropertyNullException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="System.Runtime.Serialization.SerializationInfo">SerializationInfo</see> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext">StreamingContext</see> that contains contextual information about the source or destination.</param>
        /// <exception cref="System.ArgumentNullException">The <i>info</i> parameter is <b>null</b>.</exception>
        /// <exception cref="System.Runtime.Serialization.SerializationException">The class name is <b>null</b> or <see cref="System.Exception.HResult">HResult</see> is zero (0).</exception>
        /// <remarks>
        /// This constructor is called during deserialization to reconstitute the exception object transmitted over a stream. For more information, see <a href="https://msdn.microsoft.com/en-us/library/90c86ass(v=vs.110).aspx">XML and SOAP Serialization</a>.
        /// </remarks>
        /// <seealso cref="System.Runtime.Serialization.SerializationInfo"/>
        /// <seealso cref="System.Runtime.Serialization.StreamingContext "/>
        protected PropertyNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PropertyNullException class with the name of the property that causes this exception.
        /// </summary>
        /// <param name="propertyName">The name of the parameter that caused the exception.</param>
        public PropertyNullException(string propertyName) : base(Resources.Resources.ResourceManager.GetString("Prop_PropertyNull"), propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PropertyNullException class with a specified error message and the exception that is the cause of this exception.
        /// </summary>
        /// <param name="propertyName">The name of the parameter that caused the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (<b>Nothing</b> in Visual Basic) if no inner exception is specified.</param>
        public PropertyNullException(string propertyName, Exception innerException) : base(Resources.Resources.ResourceManager.GetString("Prop_PropertyNull"), propertyName, innerException)
        {
        }

        /// <summary>
        /// Initializes an instance of the PropertyNullException class with a specified error message and the name of the parameter that causes this exception.
        /// </summary>
        /// <param name="propertyName">The name of the parameter that caused the exception.</param>
        /// <param name="message">A message that describes the error.</param>
        public PropertyNullException(string propertyName, string message) : base(message, propertyName)
        {
        }

        #endregion
    }
}
