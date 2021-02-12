using System.IO;
using SOLID.Models.SingleResponsibility;

namespace SOLID.Services.SingleResponsibility
{
    public class Persistence
    {

        public void SaveToFile(Journal journal, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
            {
                File.WriteAllText(filename, journal.ToString());
            }
        }
    }
}