class Animal {
  constructor(name, sound = "roar") {
    (this.name = name), (this.sound = sound);
  }

  speak() {
    return this.sound;
  }
}
