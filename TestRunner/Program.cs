using ConfluenceClient.Confluence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Page page = new Page("http://localhost:8090", 557060);

            page.body.storage.UpdateMacroContent("chart", "<table><tbody><tr><th>Hour</th><th>Errors</th></tr><tr><td>00</td><td>5</td></tr><tr><td>01</td><td>18</td></tr><tr><td>02</td><td>25</td></tr><tr><td>03</td><td>6</td></tr><tr><td>04</td><td>66</td></tr><tr><td>05</td><td>16</td></tr></tbody></table>");

            page.Update();

        }
    }
}
