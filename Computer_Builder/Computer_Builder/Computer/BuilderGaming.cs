using Computer_Builder.Interfaces;

namespace Computer_Builder.Computer;

public class BuilderGaming : IBuilder
{
    private Computer _comp = new Computer();

    public void SetVideoCard()
    {
        Console.WriteLine("Установлена видеокарта: Palit GeForce RTX 3060 Ti Dual [NED306T019P2-1046D]");
        this._comp.VideoCard = "Palit GeForce RTX 3060 Ti Dual [NED306T019P2-1046D]";
    }

    public void SetCpu()
    {
        Console.WriteLine("Установлен процессор: AMD Ryzen 7 7800X3D BOX");
        this._comp.Cpu = "AMD Ryzen 7 7800X3D BOX";
    }
    
    public void SetMotherboard()
    {
        Console.WriteLine("Установлена материнская плата: MSI H310M PRO-VDH");
        this._comp.MotherBoard = "MSI H310M PRO-VDH";
    }
    
    public void SetPowerUnit()
    {
        Console.WriteLine("Установлен блок питания: DEEPCOOL PF600 [R-PF600D-HA0B-EU]");
        this._comp.PowerUnit = "DEEPCOOL PF600 [R-PF600D-HA0B-EU]";
    }
    
    public void SetMemory()
    {
        Console.WriteLine("Установлена оперативная память: AMD Radeon R9 Gamer Series [R9S416G3206U2K] 16 ГБ");
        this._comp.Memory = "DEEPCOOL PF600 [R-PF600D-HA0B-EU]";
    }

    public void SetRgbLight()
    {
        Console.WriteLine("Установлена RGB-подсветка ");
        this._comp.RgbLight = true;
    }  
}