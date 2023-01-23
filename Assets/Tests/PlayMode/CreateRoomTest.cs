using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CreateRoomTest
{
    [UnityTest]
    public IEnumerator CreateRoomErrorTest()
    {
        SceneManager.LoadScene(2);
        yield return null;

        GameObject CRButton = GameObject.Find("Canvas/Panel/CreateRoom");
        CRButton.GetComponent<Button>().onClick.Invoke();
        yield return null;

        GameObject ErrorPanel = GameObject.Find("Canvas/Panel/ErrorBox");

        Assert.AreEqual(true, ErrorPanel.activeSelf);

        GameObject OKButton = GameObject.Find("Canvas/Panel/ErrorBox/Okay");
        OKButton.GetComponent<Button>().onClick.Invoke();
        yield return null;

        Assert.AreEqual(false, ErrorPanel.activeSelf);
    }

    [UnityTest]
    public IEnumerator SlideRangeValidationTest()
    {
        GameObject testObject = new GameObject();
        testObject.AddComponent<StaticValues>();

        SlideRangeDD testSlider = testObject.AddComponent<SlideRangeDD>();
        testSlider.TesterInitialization();

        yield return null;

        testSlider.SlideRange1("9");
        Assert.AreEqual(true, StaticValues.validStartInputRange);

        testSlider.SlideRange1("0");
        Assert.AreEqual(false, StaticValues.validStartInputRange);

        testSlider.SlideRange1("-10");
        Assert.AreEqual(false, StaticValues.validStartInputRange);

        testSlider.SlideRange1("Happy");
        Assert.AreEqual(false, StaticValues.validStartInputRange);

        testSlider.SlideRange2("10");
        Assert.AreEqual(true, StaticValues.validEndInputRange);

        testSlider.SlideRange2("0");
        Assert.AreEqual(false, StaticValues.validStartInputRange);

        testSlider.SlideRange2("-1");
        Assert.AreEqual(false, StaticValues.validEndInputRange);

        testSlider.SlideRange2("Sad");
        Assert.AreEqual(false, StaticValues.validEndInputRange);
    }

    [UnityTest]
    public IEnumerator PathValidationTest()
    {
        GameObject testObject = new GameObject();
        testObject.AddComponent<StaticValues>();

        CRbutton button = testObject.AddComponent<CRbutton>();
        button.TesterInitialization();

        yield return null;

        Assert.AreEqual(false, button.ErrorBoxActive());

        StaticValues.slidePath = "C:\\";
        button.CreateRoom();

        Assert.AreEqual(true, button.ErrorBoxActive());

        button.CloseError();
        StaticValues.slidePath = "";
        button.CreateRoom();

        Assert.AreEqual(true, button.ErrorBoxActive());

        button.CloseError();
        StaticValues.slidePath = "..\\Senior_Project\\Assets\\Tests\\TestSlides";
        StaticValues.SlideRange = false;
        StaticValues.rtr = 0;
        button.CreateRoom();

        yield return null;

        Assert.AreEqual(5, SceneManager.GetActiveScene().buildIndex);
    }
}
