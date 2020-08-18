using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Antlr4.Runtime;

namespace JProperties
{
    /// <summary>
    /// Extension class for convenience 
    /// </summary>
    public static class JPropertiesStringExtension
    {
        /// <summary>
        /// Generates a string that can safely be saved to a Properties list
        /// </summary>
        /// <returns>A string where line terminators are escaped</returns>
        public static string ToJPropertyString(this string value)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(char c in value)
            {
                if ((int)c >= 128)
                {
                    stringBuilder.AppendFormat("\\u{0:x4}", (int)c);
                }
                else
                {
                    stringBuilder.Append(c);
                }
            }
            return stringBuilder.ToString().Replace("\r", "\\r").Replace("\n", "\\n");
        }
    }
}

namespace JProperties
{
    /// <summary>
    /// Provides IO capabilities on Java Property files
    /// </summary>
    public class Properties : Dictionary<string, string>
    {
        /// <summary>
        /// Creates a Properties object
        /// </summary>
        /// <returns>An empty Properties object</returns>
        public Properties() : base() {}

        /// <summary>
        /// Creates a Properties object using the given defaults
        /// </summary>
        /// <param name="defaults">The Properties object defining default values</param>
        /// <returns>A Properties object with the same properties as the argument</returns>
        public Properties(Properties defaults) : base(defaults) {}

        /// <summary>
        /// Creates a Properties object using the given defaults
        /// </summary>
        /// <param name="defaults">The Properties object defining default values</param>
        /// <returns>A Properties object with the same properties as the argument</returns>
        public Properties(IDictionary<string, string> defaults) : base(defaults) {}

        /// <summary>
        /// Loads property values from a given character stream.
        /// </summary>
        /// <param name="propertyStream">A stream providing text, like that of a file.</param>
        public void Load(Stream propertyStream)
        {
            // Open the stream for reading
            using (StreamReader reader = new StreamReader(propertyStream, Encoding.GetEncoding("ISO-8859-1")))
            {
                // open the lexers/parsers to generate key-value pairs
                AntlrInputStream inputStream = new AntlrInputStream(reader);
                JPropertiesLexer lexer = new JPropertiesLexer(inputStream);
                CommonTokenStream tokenStream = new CommonTokenStream(lexer);
                JPropertiesParser parser = new JPropertiesParser(tokenStream);

                // See the grammar spec for more information
                JPropertiesParser.FileContext file = parser.file();
                if (file != null)
                {
                    // Grab all natural lines in the properties
                    JPropertiesParser.LineContext[] lines = file.line();
                    if (lines != null)
                    {
                        // Not all lines have a key-value pair as per spec
                        foreach(var line in lines)
                        {
                            JPropertiesParser.PropertyContext prop = line.property();
                            if (prop != null)
                            {
                                // Store key-value pair
                                JPropertiesParser.KeyContext key = prop.key();
                                JPropertiesParser.ValueContext value = prop.value();
                                base.Add(key.GetText(), value == null ? "" : Regex.Unescape(value.GetText()));
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Store property values into a given character stream.
        /// </summary>
        /// <param name="propertyStream">A stream with which to store properties</param>
        public void Store(Stream propertyStream)
        {
            // Open stream for writing
            using (StreamWriter writer = new StreamWriter(propertyStream, Encoding.GetEncoding("ISO-8859-1")))
            {
                foreach(KeyValuePair<string, string> prop in this)
                {
                    writer.WriteLine($"{prop.Key.ToJPropertyString()}={prop.Value.ToJPropertyString()}");
                }
            }
        }
    }
}
