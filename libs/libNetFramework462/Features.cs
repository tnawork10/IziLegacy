using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libNetFramework462
{
    // primary consturctor is feature of LangVersion 12.0
    public class Features(int i)
    {
        /// <summary>
        ///  need nuget <PackageReference Include="System.ValueTuple" /> 
        ///  https://www.nuget.org/packages/System.ValueTuple
        /// </summary>
        /// <returns></returns>
        public (int val, int val2) Tuple2()
        {
            return (i, 1);
        }
    }
}
