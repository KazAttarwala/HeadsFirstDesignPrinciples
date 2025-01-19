Duck model = new ModelDuck();
model.setFlyBehavior(new FlyRocketPowered());
model.setQuackBehavior(new Squeak());
model.display();
model.performQuack();
model.performFly();


