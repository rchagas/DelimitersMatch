using DelimitersMatch;
using Xunit;

public class UnitTest {
    [Fact]
    public void MatchTest()
    {
        Assert.True(Program.DelimitersMatch("(){}[]"));
        Assert.True(Program.DelimitersMatch("[{()}](){}"));
        Assert.True(Program.DelimitersMatch("({{[]}({}[])[(){}]}[{{[]}({}[])[(){}]}]){{[]}({}[])[(){}]}{{[]}({}[])[(){}]}"));
    }
    [Fact]
    public void MismatchTest()
    {
        Assert.False(Program.DelimitersMatch("[][{}{}"));
        Assert.False(Program.DelimitersMatch("{}{}{}["));
        Assert.False(Program.DelimitersMatch("{{[]}({}[])[(){}]}{{[]}({}[])[(){}]}[]{())}[]"));
    }
    
    /*
        Teste obsoleto considerando caracteres não delimitadores como exceção
    */
    // [Fact]
    // public void ErrorTest(){
    //     Assert.Throws<InvalidDataException>(() => Program.DelimitersMatch("a"));
    //     Assert.Throws<InvalidDataException>(() => Program.DelimitersMatch("[](){}'"));
    //     Assert.Throws<InvalidDataException>(() => Program.DelimitersMatch("[{(x)}]"));
    //     Assert.Throws<InvalidDataException>(() => Program.DelimitersMatch("{()}{{}}{[@]}"));
    // }
    
}