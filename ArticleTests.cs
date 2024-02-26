using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;
    [SetUp]
    public void SetUp()
    {
        this._article = new Article();
    }


    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] articleData =
        {
            "Article Content Author",
            "Article2 Content2 Authot2",
            "Article3 Content3 Author3"
        };

        // Act
        Article result = this._article.AddArticles(articleData);
        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        Article inputArticle = new Article()
        {
            ArticleList = new()
            {
                new Article()
                {
                Author = "Boyana",
                Content = "Love stories",
                Title = "I Love"
                },
               new Article()
               {
                Author = "BoyanaAngelova",
                Content = "Fantastic stories",
                Title = "Fantastic world"
               }
            }
        };
        string expected = $"Fantastic world - Fantastic stories: BoyanaAngelova{Environment.NewLine}I Love - Love stories: Boyana";
        //Act
        string result = this._article.GetArticleList(inputArticle, "title");
        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        Article inputArticle = new Article();
        string result = this._article.GetArticleList(inputArticle, "not- criteria");

        Assert.That(result, Is.Empty);
    }
    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenNoArticleInList()
    {
        Article inputArticle = new Article();
        string result = this._article.GetArticleList(inputArticle, "content");

        Assert.That(result, Is.Empty);

    }
}