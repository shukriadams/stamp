using System.Reflection;

namespace Stamp
{
    public static class Stamp
    {
        /// <summary>
        /// Returns the value of the given property in the model object.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public static string Value(object model, string property)
        {
            if (model == null)
                return string.Empty;

            PropertyInfo p = model.GetType().GetProperty("name");
            return property == null ? string.Empty : p.GetValue(model, null).ToString();

        }
    }
}