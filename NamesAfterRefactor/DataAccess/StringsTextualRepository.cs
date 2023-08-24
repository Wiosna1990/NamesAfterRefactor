using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NamesAfterRefactor.DataAccess;


class StringsTextualRepository
{
    private static readonly string Separator = Environment.NewLine;
    public List<string> Read(string filePath)
    {
        var fileContents = File.ReadAllText(filePath);
        return fileContents.Split(Separator).ToList();

    }

    public void Write(string filePath, List<string> strings) =>
        File.WriteAllText(filePath, string.Join(Separator, strings));

}

