class Blog:
    def __init__(self, title, author):
        self.title = title
        self.author = author
        self.posts = []

    def create_post(self, title, content):
        self.posts.append({"title": title, "content": content})

    def __repr__(self):
        return f"{self.title} by {self.author} ({len(self.posts)} post{'s' if len(self.posts) > 1 else ''})"

    def json(self):
        return {
            "title": self.title,
            "author": self.author,
            "posts": self.posts
        }
