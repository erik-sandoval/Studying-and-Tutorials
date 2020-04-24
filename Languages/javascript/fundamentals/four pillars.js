class Animal {
  constructor(name, sound = "roar") {
    (this.name = name), (this.sound = sound);
  }

  speak() {
    console.log('hi')
    return this.sound;
  }
}
