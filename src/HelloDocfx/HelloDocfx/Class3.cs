using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDocfx
{
    public class Class3:Class1
    {
        /// <summary>
        /// FileMapping supports 3 forms:
        /// 1. Array form
        ///     This form supports multiple file mappings, and also allows additional properties per mapping.
        ///     e.g.
        ///     <code>
        ///     "key": [
        ///       {"files": ["file1", "file2"], "dest": "dest1"},
        ///       {"files": "file3", "dest": "dest2"},
        ///       {"files": ["file4", "file5"], "exclude": ["file5"], "src": "folder1"},
        ///       {"files": "Example.yml", "src": "v1.0", "dest":"v1.0/api", "group": "v1.0"},
        ///       {"files": "Example.yml", "src": "v2.0", "dest":"v2.0/api", "group": "v2.0"}
        ///     ]
        ///     </code>
        /// 2. Compact form
        ///     This form supports multiple file patterns in an array
        ///     e.g. <code>projects: ["file1", "file2"]</code>
        /// 3. Object form
        ///     If the Array form contains only one item, it can be shortened to an object
        ///     e.g. <code>projects: ["file1", "file2"]</code>
        /// </summary>
        /// <returns>fff</returns>
        public string abc { get; set; }

        /// <summary>
        /// class3gougao
        /// </summary>
        public Class3():base("abc")
        {
            this.abc = "abc";
        }   
    }
}
