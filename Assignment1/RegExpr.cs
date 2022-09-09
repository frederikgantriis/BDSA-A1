using System.Text.RegularExpressions;
using System.Linq;

namespace Assignment1;

public static class RegExpr
{
    public static IEnumerable<string> SplitLine(IEnumerable<string> lines) => from item in lines
                                                                              from word in Regex.Split(item, @"\W+")
                                                                              select word;

    public static IEnumerable<(int width, int height)> Resolution(IEnumerable<String> resolutions)
    {
        var pattern = new Regex(@"(\d+)x(\d+)");
        return from item in resolutions
               from match in pattern.Matches(item).Cast<Match>()
               select (int.Parse(match.Groups[1].Value), int.Parse(match.Groups[2].Value));
    }

    public static IEnumerable<string> InnerText(string html, string tag) => from Match match in Regex.Matches(html, $@"<{tag}.*?>(.*?)</{tag}>")
                                                                           select match.Groups[1].Value;
}