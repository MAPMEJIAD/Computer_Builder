using Computer_Builder.Interfaces;

namespace Computer_Builder.Computer;

public class BuilderDefault : IBuilder
{
    private Computer _comp = new Computer();

    public void SetVideoCard()
    {
        Console.WriteLine("Установлена видеокарта: GIGABYTE GeForce GT 710 LP (rev. 2.0) [GV-N710D3-2GL Rev2.0]");
        this._comp.VideoCard = "GIGABYTE GeForce GT 710 LP (rev. 2.0) [GV-N710D3-2GL Rev2.0]";
    }

    public void SetCpu()
    {
        Console.WriteLine("Установлен процессор: AMD FX-4300 BOX");
        this._comp.Cpu = "AMD FX-4300 BOX";
    }
    
    public void SetMotherboard()
    {
        Console.WriteLine("Установлена материнская плата: Esonic H61DA1 V5.1");
        this._comp.MotherBoard = "Esonic H61DA1 V5.1";
    }
    
    public void SetPowerUnit()
    {
        Console.WriteLine("Установлен блок питания: HIPER HPT-400");
        this._comp.PowerUnit = "HIPER HPT-400";
    }
    
    public void SetMemory()
    {   
        Console.WriteLine("Установлена оперативная память: DEXP [DEXP4GD3UD16] 4 ГБ");
        this._comp.Memory = "DEXP [DEXP4GD3UD16] 4 ГБ";
    }

    public void SetRgbLight()
    {
        Console.WriteLine("RGB-подсветка отсутствует");
        this._comp.RgbLight = false;
    }
}