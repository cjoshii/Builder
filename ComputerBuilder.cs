internal class ComputerBuilder : IComputerBuilder
{
    private IComputer computer = new Computer();

    public IComputer Build()
    {
        return computer;
    }

    public IComputerBuilder SetCPU(string cpu)
    {
        computer.CPU = cpu;
        return this;
    }

    public IComputerBuilder SetGPU(string gpu)
    {
        computer.GPU = gpu;
        return this;
    }

    public IComputerBuilder SetMemory(string memory)
    {
        computer.Memory = memory;
        return this;
    }

    public IComputerBuilder SetStorage(string storage)
    {
        computer.Storage = storage;
        return this;
    }
}