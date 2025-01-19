class ModelDuck : Duck {
    public ModelDuck() {
        flyBehavior = new FlyNoWings();
        quackBehavior = new Quack();
    }
    public void display() {
        Console.WriteLine("I'm a model duck");
    }
}