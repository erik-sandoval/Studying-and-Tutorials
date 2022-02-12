from unittest import TestCase
from tests.blog import Blog


class BlogTest(TestCase):
    def test_create_blog(self):
        blog = Blog("How to bake a cake", "John Appleseed")
        self.assertEqual("How to bake a cake", blog.title)
        self.assertEqual("John Appleseed", blog.author)
        self.assertListEqual([], blog.posts)

    def test_repr(self):
        blog = Blog("Test Blog", "John Appleseed")
        blog1 = Blog("Test Blog 2", "Erik")
        blog2 = Blog("Test Blog 2", "Erik")

        blog1.create_post("test", "content")
        blog1.create_post("test", "content")
        blog1.create_post("test", "content")

        blog2.create_post("test", "content")

        self.assertEqual("Test Blog by John Appleseed (0 post)", blog.__repr__())
        self.assertEqual("Test Blog 2 by Erik (3 posts)", blog1.__repr__())
        self.assertEqual("Test Blog 2 by Erik (1 post)", blog2.__repr__())

    def test_multiple_post_repr(self):
        blog = Blog("Test Blog", "Erik")

        blog.create_post("test", "content")
        blog.create_post("test", "content")
        blog.create_post("test", "content")

        self.assertEqual("Test Blog by Erik (3 posts)", blog.__repr__())
