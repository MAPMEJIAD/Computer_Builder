using Computer_Builder.Interfaces;
namespace Computer_Builder.Computer;


public class Director
{
    private IBuilder _builder;
    
    public IBuilder Builder
    {
        set { _builder = value; } 
    }
    
    public void BuildComputer()
    {
        this._builder.SetVideoCard();
        this._builder.SetCpu();
        this._builder.SetMotherboard();
        this._builder.SetPowerUnit();
        this._builder.SetMemory();
        this._builder.SetRgbLight();
        
    }
}
