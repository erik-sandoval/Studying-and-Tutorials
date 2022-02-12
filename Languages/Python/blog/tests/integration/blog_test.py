from unittest import TestCase

from tests.blog import Blog


class BlogTest(TestCase):

    def test_create_post(self):
        blog = Blog("Test Blog", "John Appleseed")
        blog.create_post("How lose weight", "test content")

        self.assertEqual("Test Blog", blog.title)
        self.assertEqual("John Appleseed", blog.author)
        self.assertEqual("How lose weight", blog.posts[0].title)
        self.assertEqual("test content", blog.posts[0].content)

    def test_json(self):
        blog = Blog("Test Blog", "Erik")
        blog1 = Blog("Test Blog", "Erik")

        blog1.create_post("How lose weight", "test content")
        self.assertDictEqual({"title": "Test Blog", "author": "Erik", "posts": []}, blog.json())
        self.assertDictEqual({"title": "Test Blog", "author": "Erik",
                              "posts": [{"title": "How lose weight", "content": "test content"}]}, blog1.json())
