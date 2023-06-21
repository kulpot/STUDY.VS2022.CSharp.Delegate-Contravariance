using System;

//ref link:https://www.youtube.com/watch?v=QHuN5dn2f0w&list=PLAE7FECFFFCBE1A54&index=24
//

class Base { }
class Derived : Base { };

delegate void MyDelegate(Base b);
delegate void MyOtherDelegate(Derived d); //Contravariant

class MainClass
{
    static void TakeDerived(Derived d) { }
    static void TakeBase(Base b) { }
    static void Main()
    {
        /*MyDelegate d1 = TakeDerived;
        d1(new Derived());
        d1(new Base());
        MyDelegate d2 = TakeBase;*/
        MyOtherDelegate d1 = TakeDerived;
        MyOtherDelegate d2 = TakeBase;
        //d1(new Base());
        d2(new Derived());
    }
}