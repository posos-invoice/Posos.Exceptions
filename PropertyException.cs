using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Posos.Exceptions
{
    /// <summary>
    /// The exception that is thrown when a property is set to a not valid value.
    /// </summary>
    /// <seealso cref="System.SystemException"/>
    public class PropertyException : System.SystemException
    {
        #region Variables

        /// <summary>
        /// The property name.
        /// </summary>
        private String m_propertyName = null;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the name of the property that causes this exception.
        /// </summary>
        public String PropertyName
        {
            get
            {
                return m_propertyName;
            }
        }


        /// <summary>
        /// Gets the error message and the property name, or only the error message if no property name is set. (Overrides Exception.Message.)
        /// </summary>
        public override String Message
        {
            get
            {
                if (m_propertyName == null)
                {
                    return base.Message;
                }
                else
                {
                    return String.Format("{0}\r\n{1}", base.Message, String.Format(Resources.Resources.ResourceManager.GetString("Prop_PropertyName"), m_propertyName));
                }
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the PropertyException class.
        /// </summary>
        public PropertyException() : base(Resources.Resources.ResourceManager.GetString("Prop_PropertyException"))
        {
            m_propertyName = null;
        }

        /// <summary>
        /// Initializes a new instance of the PropertyException class with serialized data.
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
        protected PropertyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArgumentException class with a specified error message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public PropertyException(String message) : base(message)
        {
            m_propertyName = null;
        }

        /// <summary>
        /// Initializes a new instance of the PropertyException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the innerException parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.</param>
        public PropertyException(String message, Exception innerException) : base(message, innerException)
        {
            m_propertyName = null;
        }

        /// <summary>
        /// Initializes a new instance of the PropertyException class with a specified error message and the name of the property that causes this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="propertyName">The name of the property that caused the current exception.</param>
        public PropertyException(String message, String propertyName) : base(message)
        {
            m_propertyName = propertyName;
        }

        /// <summary>
        /// Initializes a new instance of the PropertyException class with a specified error message and the name of the property that causes this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="propertyName">The name of the property that caused the current exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the innerException parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.</param>
        public PropertyException(String message, String propertyName, Exception innerException) : base(message, innerException)
        {
            m_propertyName = propertyName;
        }

        #endregion
    }
}
