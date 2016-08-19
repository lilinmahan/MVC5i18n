using System;
using System.Web;

namespace MVC5i18n.Manager.Session
{
    public static class SessionManager
    {
        #region Methods to access to variables Session
        /// <summary>
        /// get object specified by key in session
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>an object matched to key received</returns>
        public static Object GetObject(string key)
        {
            return (HttpContext.Current.Session != null && HttpContext.Current.Session[key] != null)
                ? HttpContext.Current.Session[key] : null;
        }

        public static Object GetObject(Enum key)
        {
            return GetObject(key.ToString());
        }

        /// <summary>
        /// put object specified in session
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        public static void PutObject(string key, Object value)
        {
            if (HttpContext.Current.Session != null)
            {
                if (HttpContext.Current.Session[key] != null)
                    HttpContext.Current.Session.Remove(key);
                HttpContext.Current.Session.Add(key, value);
            }
        }

        /// <summary>
        /// Puts the object.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public static void PutObject(Enum key, Object value)
        {
            PutObject(key.ToString(), value);
        }

        /// <summary>
        /// remove object specified in Session
        /// </summary>
        /// <param name="key">key</param>
        public static void RemoveObject(string key)
        {
            if (HttpContext.Current.Session != null && HttpContext.Current.Session[key] != null)
                HttpContext.Current.Session.Remove(key);
        }

        /// <summary>
        /// Removes the object.
        /// </summary>
        /// <param name="key">The key.</param>
        public static void RemoveObject(Enum key)
        {
            RemoveObject(key.ToString());
        }

        #endregion
    }
}