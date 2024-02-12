namespace FirstUnitTest.Test;

public class UnitTest1
{
    //Functionality
    public int method(int value=0){
        return 9;
    }

    //Unit Test
    [Fact]
    public void Test1()
    {   
        // ARRANGE


        // ACT
        int result = method();

        //ASSERT
        Assert.IsType<int>(result);
    }

    [Fact]
    public void Test2(){
        //Arrange
        int expected = 9;
        //Act
        int result = method(9);
        
        //Asset
        Assert.Equal(expected, result);
    }
}