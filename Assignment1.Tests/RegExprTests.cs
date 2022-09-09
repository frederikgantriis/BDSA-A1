using Xunit;

namespace Assignment1.Tests;

public class RegExprTests
{
    [Fact]
    public void Given_a_stream_of_strings_return_a_list_with_each_word()
    {
        // Given
        var stream = new[] {"Hello 2839", "Aieklj392 Ujeg0923", "ienfei IEHEJG", "kjd%&#kjeg"};

        // When
        var words = Assignment1.RegExpr.SplitLine(stream);
    
        // Then
        Assert.Equal(new[] {"Hello", "2839", "Aieklj392", "Ujeg0923", "ienfei", "IEHEJG", "kjd", "kjeg"}, words);
    }

    [Fact]
    public void Given_a_resolution_returns_formatted()
    {
        // Given
        var resolutions = new[] {"1920x1080", "1024x768, 800x600, 640x480" , "320x200, 320x240, 800x600", "1280x960"};
    
        // When
        var resolution = Assignment1.RegExpr.Resolution(resolutions);
    
        // Then
        resolution.Equals(new[] {(1920, 1080), (1024, 768), (800, 600), (640, 480), (320, 200), (320, 240), (800, 600), (1280, 960)});
    }

    [Fact]
    public void Given_a_HTML_containing_tag_a_returns_the_inner_text()
    {
        // Given
        var html = "<div> <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"https://en.wikipedia.org/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"https://en.wikipedia.org/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"https://en.wikipedia.org/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"https://en.wikipedia.org/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"https://en.wikipedia.org/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"https://en.wikipedia.org/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p> </div>";
    
        // When
        var innerText = Assignment1.RegExpr.InnerText(html, "a");
    
        // Then
        Assert.Equal(new [] {"theoretical computer science", "formal language", "characters", "pattern", "string searching algorithms", "strings"}, innerText);
    }
}