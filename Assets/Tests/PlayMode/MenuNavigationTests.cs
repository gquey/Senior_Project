using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuNavigationTests
{

    [UnityTest]
    public IEnumerator LoadOpeningTest()
    {
        SceneManager.LoadScene(0);
        yield return null;

        Assert.AreEqual(SceneManager.GetActiveScene().buildIndex, 0);
    }

    [UnityTest]
    public IEnumerator MenuNavigationTest()
    {
        SceneManager.LoadScene(0);
        yield return null;

        GameObject MenuButton = GameObject.Find("Canvas/P1/Mbutton");
        MenuButton.GetComponent<Button>().onClick.Invoke();
        yield return null;

        Assert.AreEqual(1, SceneManager.GetActiveScene().buildIndex);

        GameObject HTUButton = GameObject.Find("Canvas/Panel/HTUbutton");
        HTUButton.GetComponent<Button>().onClick.Invoke();
        yield return null;

        Assert.AreEqual(0, SceneManager.GetActiveScene().buildIndex);
    }

    [UnityTest]
    public IEnumerator HTUArrowsTest()
    {
        SceneManager.LoadScene(0);
        yield return null;

        GameObject Panel1 = GameObject.Find("Canvas/P1");

        Assert.AreEqual(true, Panel1.activeSelf);

        GameObject NextButton = GameObject.Find("Canvas/P1/NextButton");
        NextButton.GetComponent<Button>().onClick.Invoke();
        yield return null;

        Assert.AreEqual(false, Panel1.activeSelf);

        GameObject Panel2 = GameObject.Find("Canvas/P2");

        Assert.AreEqual(true, Panel2.activeSelf);

        GameObject BackButton = GameObject.Find("Canvas/P2/BackButton");
        BackButton.GetComponent<Button>().onClick.Invoke();
        yield return null;

        Assert.AreEqual(true, Panel1.activeSelf);
        Assert.AreEqual(false, Panel2.activeSelf);
    }

    [UnityTest]
    public IEnumerator FAQNavigationTest()
    {
        SceneManager.LoadScene(0);
        yield return null;

        GameObject button = GameObject.Find("Canvas/P1/FAQbutton");
        button.GetComponent<Button>().onClick.Invoke();
        yield return null;

        Assert.AreEqual(4, SceneManager.GetActiveScene().buildIndex);

        button = GameObject.Find("Canvas/Panel/HTUbutton");
        button.GetComponent<Button>().onClick.Invoke();
        yield return null;

        Assert.AreEqual(0, SceneManager.GetActiveScene().buildIndex);
    }
}
