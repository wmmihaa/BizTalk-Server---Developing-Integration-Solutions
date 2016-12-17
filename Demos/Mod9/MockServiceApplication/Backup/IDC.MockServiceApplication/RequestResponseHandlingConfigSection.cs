using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Reflection;
using System.IO;

namespace IDC.MockServiceApplication
{
    public class ResponseHelper
    {
        public static string GetResponseAction(string requestAction)
        {
            RequestResponseHandlingConfigSection section = (RequestResponseHandlingConfigSection)ConfigurationManager.GetSection("requestResponseHandling");
            Action ef = section.ActionList[requestAction];
            return ef.ResponseAction;
        }

        public static string GetResponseFile(string requestAction)
        {
            RequestResponseHandlingConfigSection section = (RequestResponseHandlingConfigSection)ConfigurationManager.GetSection("requestResponseHandling");
            Action ef = section.ActionList[requestAction];
            return ef.ResponseLocation;
        }
    }

    /// <summary>
    /// The Class that will have the XML config file data loaded into it via the configuration Manager.
    /// </summary>
    public class RequestResponseHandlingConfigSection : ConfigurationSection
    {
        /// <summary>
        /// The value of the property here "actionList" needs to match that of the config file section
        /// </summary>
        [ConfigurationProperty("actionList")]
        public ActionCollection ActionList
        {
            get { return ((ActionCollection)(base["actionList"])); }
        }
    }

    /// <summary>
    /// The collection class that will store the list of each element/item that
    ///        is returned back from the configuration manager.
    /// </summary>
    [ConfigurationCollection(typeof(Action))]
    public class ActionCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new Action();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((Action)(element)).ResponseAction;
        }

        new public Action this[string key]
        {
            get
            {
                System.Collections.IEnumerator e = this.GetEnumerator();
                while (e.MoveNext())
                    if (((Action)e.Current).RequestAction.ToLower() == key.ToLower())
                        return ((Action)e.Current);
                return null;
            }
        }

    }

    /// <summary>
    /// The class that holds onto each element returned by the configuration manager.
    /// </summary>
    public class Action : ConfigurationElement
    {
        [ConfigurationProperty("requestAction", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string RequestAction
        {
            get
            {
                return ((string)(base["requestAction"]));
            }
            set
            {
                base["requestAction"] = value;
            }
        }

        [ConfigurationProperty("responseAction", DefaultValue = "", IsKey = false, IsRequired = false)]
        public string ResponseAction
        {
            get
            {
                return ((string)(base["responseAction"]));
            }

            set
            {
                base["responseAction"] = value;
            }
        }

        [ConfigurationProperty("responseLocation", DefaultValue = "", IsKey = false, IsRequired = false)]
        public string ResponseLocation
        {
            get
            {
                return ((string)(base["responseLocation"]));
            }

            set
            {
                base["responseLocation"] = value;
            }
        }
    }

}
