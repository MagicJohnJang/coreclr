using System;
/// <summary>
///Constructor
/// </summary>

public class AttributeTargetsConstructor
{
    public static int Main()
    {
        AttributeTargetsConstructor AttributeTargetsConstructor = new AttributeTargetsConstructor();

        TestLibrary.TestFramework.BeginTestCase("AttributeTargetsConstructor");
        if (AttributeTargetsConstructor.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
       TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
      
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Verify the AttributeTargets.Constructor value is 0x0020. ");
        try
        {
            int expectValue = 0x0020;
            if ((int)AttributeTargets.Constructor != expectValue)
            {
                TestLibrary.TestFramework.LogError("001.1", " AttributeTargets.Constructor should return 0x0020.");
                retVal = false;
            }
           
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }
       
        return retVal;
    }
   
}

