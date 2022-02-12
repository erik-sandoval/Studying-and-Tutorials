from unittest import TestCase
from tests.post import Post


class PostTest(TestCase):
    def test_create_post(self):
        p = Post("test", "test content")

        self.assertEqual("test", p.title)
        self.assertEqual("test content", p.content)

    def test_json(self):
        p = Post("test", "test content")

        self.assertDictEqual({"title": "test", "content": "test content"}, p.json())
