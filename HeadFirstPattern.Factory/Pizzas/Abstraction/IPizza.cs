﻿namespace HeadFirstPattern.Factory.Pizzas;

public interface IPizza
{
    void Prepare();
    void Bake();
    void Cut();
    void Box();
}
