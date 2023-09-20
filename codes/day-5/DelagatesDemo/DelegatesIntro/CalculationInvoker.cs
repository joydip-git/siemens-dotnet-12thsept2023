using System;
using System.Reflection;

namespace DelegatesIntro
{
    //1. declaring a delegate
    delegate int CalculationInvoker(int a, int b);

    //class CalculationDelegate//:MulticastDelegate:Delegate:Object
    //{
    //    private Object _target;
    //    private MethodInfo _method;

    //    public CalculationDelegate(Object target, MethodInfo method)
    //    {
    //        _target = target;
    //        _method = method;
    //    }
    //    public MethodInfo Method {  return _method; }
    //    public object Target {  return _target; }

    //    public int Invoke(int a, int b)
    //    {
    //        return _method.Invoke(_target, new object[] { a, b });
    //    }
    //}
}
