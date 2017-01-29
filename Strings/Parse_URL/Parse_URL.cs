using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_URL
{
    class Parse_URL
    {
        static void Main(string[] args)
        {
        string adressURL = Console.ReadLine();

        int index = adressURL.IndexOf("://");
        string protocol = adressURL.Substring(0, index);


        int index1 = adressURL.IndexOf('/', index + 3);
        string server = adressURL.Substring(index + 3, index1 - index - 3);


        string resource = adressURL.Substring(index1);

        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
/*        var fragments = Regex.Match(uri, "(.*)://(.*?)(/.*)").Groups;

        Console.WriteLine(fragments[1]);
        Console.WriteLine(fragments[2]);
        Console.WriteLine(fragments[3]);*/


/*            string adressURL = Console.ReadLine();

        int index = adressURL.IndexOf("://");
        string protocol = adressURL.Substring(0, index);


        int index1 = adressURL.IndexOf('/', index + 3);
        string server = adressURL.Substring(index + 3, index1 - index - 3);


        string resource = adressURL.Substring(index1);

        Console.WriteLine(protocol);
        Console.WriteLine(server);
        Console.WriteLine(resource);*/

/*
        StringBuilder url = new StringBuilder(Console.ReadLine());
        string protocol = url.ToString().Substring(0, url.ToString().IndexOf("://"));
        Console.WriteLine("[protocol] = " + protocol);

        url.Remove(0, protocol.Length + 3);
        string server = url.ToString().Substring(0, url.ToString().IndexOf("/"));
        Console.WriteLine("[server] = " + server);

        url.Remove(0, server.Length);
        string resource = url.ToString();
        Console.WriteLine("[resource] = " + resource);
*/
