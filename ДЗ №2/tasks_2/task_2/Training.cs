public class Training
{
    public object[] data; // массив для хранения лекций и пз

    private int counter = 0; // счетчик объектов(в нашем случае лекций и пз)

    public string name; // название тренинга

    public Training(string name, params object[] data) // при создании тренинга нужно ввести его название(можно пустую строку или null) + можно сразу добавить лекции и пз(не обязательно)
    {
        this.name = name;
        for (int i = 0; i < data.Length; i++)
            this.Add(data[i]);
    }

    public void Add(object element)
    {
        if (counter == 0)
        {
            data = new object[counter + 1];
            data[counter] = element;
        }
        else
        {
            object[] old_data = new object[counter];
            old_data = data;
            data = new object[counter + 1];
            data[counter] = element;
            for (int i = 0; i < old_data.Length; i++)
                data[i] = old_data[i];
        }
        counter++;
    }

    public bool IsPractical()
    {
        foreach (object value in data)
            if (value.ToString() == "Lecture")
                return false;
        return true;
    }

    public Training Clone()
    {
        string new_name = name;
        _ = new object[counter];
        object[] new_data = data;
        return new Training(new_name, new_data);
    }

    public string Show() // этот метод я создал для проверки корректной работы программы в консоли
    {
        string elements_str = "";
        if(data != null)
        foreach (object value in data)
            elements_str += value + "\n";
        return elements_str;    
    }
}