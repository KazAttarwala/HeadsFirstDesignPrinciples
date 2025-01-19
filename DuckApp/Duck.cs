abstract class Duck {
    public IFlyBehavior flyBehavior;
    public IQuackBehavior quackBehavior;

    public void display() {
        Console.WriteLine("displaying");
    }
    public void performFly() {
        flyBehavior.fly();
    }
    public void performQuack() {
        quackBehavior.quack();
    }
    public void setFlyBehavior(IFlyBehavior fb) {
        flyBehavior = fb;
    }
    public void setQuackBehavior(IQuackBehavior qb) {
        quackBehavior = qb;
    }
}