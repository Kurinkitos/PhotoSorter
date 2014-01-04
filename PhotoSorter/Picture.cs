using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSorter
{
    public class Picture : IComparable<Picture>
    {
        public string filePath;
        public DateTime lastModified;

        public Picture(string filePathIn, DateTime lastModifiedIn)
        {
            filePath = filePathIn;
            lastModified = lastModifiedIn;
        }

        public int CompareTo(Picture other)
        {
            return lastModified.CompareTo(other.lastModified);
        }
    }
}
