//The following code example creates an empty Dictionary<TKey, TValue> of
//strings with string keys and uses the Add method
//to add some elements.The example demonstrates that the Add method throws an
//ArgumentException when attempting to add a duplicate key.

//The example uses the Item[] property (the indexer in C#) to retrieve values,
//demonstrating that a KeyNotFoundException is thrown when a
//requested key is not present, and showing that the value associated with a key can be replaced.

//The example shows how to use the TryGetValue method as a more efficient way to
//retrieve values if a program often must try key values that are not in the
//dictionary, and it shows how to use the ContainsKey method to
//test whether a key exists before calling the Add method.

//The example shows how to enumerate the keys and values in the dictionary and
//how to enumerate the keys and values alone using the Keys property and
//the Values property.

//Finally, the example demonstrates the Remove method.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dictionary
{
    class Program
    {
        public static void Main()
        {
            DictionaryEx dictEx = new DictionaryEx();
            dictEx.DictionaryInit();
            Console.ReadKey();
        }
    }

    public class DictionaryEx
    {
        public void DictionaryInit()
        {
            // Create a new dictionary of strings, with string keys.
            Dictionary<string, string> dict = new Dictionary<string, string>();

            // Add some elements to the dictionary. There are no
            // duplicate keys, but some of the values are duplicates.
            dict.Add("01", "A");
            dict.Add("02", "B");
            dict.Add("03", "B");
            dict.Add("04", "C");

            // The Add method throws an exception if the new key is
            // already in the dictionary.
            string key = "01";
            string value = "D";
            try
            {
                dict.Add(key, value);
            }
            catch (Exception)
            {
                Console.WriteLine($"\"{key}\" is already used " + "and its vlaue is : {0}", dict[key]);
            }
            Console.WriteLine("---------------------");

            // The Item property is another name for the indexer, so you
            // can omit its name when accessing elements.
            //Item[] property(the indexer in C#)
            //فقط هم ایتم پراپرتی دیکشنری کلید میگیره
            Console.WriteLine("for key = \"01\", value={0}.", dict["01"]);
            Console.WriteLine(dict["01"]);

            //foreach(Dictionary<string,string> printDict in dict)
            //{
            //    Console.WriteLine(printDict);
            //}//Error: Cannot convert type 'System.Collections.Generic.KeyValuePair<string, string>' to 'System.Collections.Generic.Dictionary<string, string>'

            Console.WriteLine("---------------------");

            foreach (KeyValuePair<string, string> kvp in dict)
            {
                Console.WriteLine(kvp);
            }

            Console.WriteLine("---------------------");

            foreach (KeyValuePair<string, string> kvp in dict)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }

            Console.WriteLine("---------------------");

            //// The indexer can be used to change the value associated
            //// with a key.

            //dict["04"] = "\"c\"";

            //foreach (KeyValuePair<string, string> kvp in dict)
            //{
            //    Console.WriteLine(kvp.Key + ": " + kvp.Value);
            //}

            //Console.WriteLine("---------------------");

            //// If a key does not exist, setting the indexer for that key
            //// adds a new key/value pair.

            //dict["05"] = "D";

            //foreach (KeyValuePair<string, string> kvp in dict)
            //{
            //    Console.WriteLine(kvp.Key + ": " + kvp.Value);
            //}

            //Console.WriteLine("---------------------");

            //// The indexer throws an exception if the requested key is
            //// not in the dictionary.

            //try
            //{
            //    Console.WriteLine("for key \"100\" vlaue is: {0}", dict["100"]);
            //    Console.WriteLine(dict["100"]);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("the key does not exit");
            //}

            //Console.WriteLine("---------------------");

            //// When a program often has to try keys that turn out not to
            //// be in the dictionary, TryGetValue can be a more efficient
            //// way to retrieve values.

            //string value01;
            //if (dict.TryGetValue("100",out value01))
            //{
            //    Console.WriteLine("for \"100\" key vlaue is: {0}",value01);
            //}
            //else
            //{
            //    Console.WriteLine("key is not found");
            //}

            //if (dict.TryGetValue("01", out value01))
            //{
            //    Console.WriteLine("for \"01\" key vlaue is: {0}", value01);
            //}
            //else
            //{
            //    Console.WriteLine("key is not found");
            //}

            //Console.WriteLine("---------------------");

            //// ContainsKey can be used to test keys before inserting
            //// them.

            //if (dict.ContainsKey("01"))
            //{
            //    Console.WriteLine(dict["01"]);
            //}

            //if (dict.ContainsKey("100"))
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}

            //if (!dict.ContainsKey("05"))
            //{
            //    dict.Add("05", "D");
            //    Console.WriteLine("05: {0}", dict["05"]);
            //}

            //Console.WriteLine("---------------------");

            //// When you use foreach to enumerate dictionary elements,
            //// the elements are retrieved as KeyValuePair objects.

            //foreach(KeyValuePair<string,string> kvp in dict)
            //{
            //    Console.WriteLine("key: {0}  value: {1}", kvp.Key, kvp.Value);
            //}

            //Console.WriteLine("---------------------");

            //// To get the values alone, use the Values property.

            //Dictionary<string, string>.ValueCollection value02 = dict.Values;

            //foreach (var print in value02)
            //{
            //    Console.WriteLine(print);
            //}

            //// The elements of the ValueCollection are strongly typed
            //// with the type that was specified for dictionary values.

            //foreach (string print in value02)
            //{
            //    Console.WriteLine("Value = {0}", print);
            //}

            //Console.WriteLine("---------------------");

            //// To get the keys alone, use the Keys property.

            //Dictionary<string, string>.KeyCollection key01 = dict.Keys;

            //// The elements of the KeyCollection are strongly typed
            //// with the type that was specified for dictionary keys.

            //foreach (string print in key01)
            //{
            //    Console.WriteLine("key: {0}", print);
            //}

            //Console.WriteLine("---------------------");

            //// Use the Remove method to remove a key/value pair.

            //Console.WriteLine("04: {0}", dict["04"]);//04: C
            //dict.Remove("04");

            //if (!dict.ContainsKey("04"))
            //{
            //    Console.WriteLine("04 key deleted");
            //}

            //Console.WriteLine("---------------------");


        }
    }
}

//The Dictionary<TKey, TValue> generic class provides a mapping from a set of keys to a set of values.
//Each addition to the dictionary consists of a value and its associated key. Retrieving a
//value by using its key is very fast, close to O(1), because the Dictionary<TKey, TValue> class is implemented as a hash table.
//هشتیبل مثل همین دیکشنری هستش که کلید و ولیو میگیره ولی هش میکند یعنی
//کلید رو نگه میدارد و مقدارش را با ایندکس ها ذخیره میکند
//یعنی مقدار رو که هرچیزی هست هش میکند چون خواندن ایندکس برای ماشین سریع تر از خواندن مقدار است برعکس انسان
//The speed of retrieval depends on the quality of the hashing algorithm of the type specified for TKey.
