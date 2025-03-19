using Microsoft.Win32; // Импортируем пространство имен для работы с реестром

// Класс для чтения и записи данных в реестре
public class RegistryHelper
{
    // Метод для чтения значения из реестра по указанному пути и имени ключа
    public static object ReadValue(string path, string name)
    {
        // Открываем ключ реестра по пути в режиме только для чтения
        using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, false))
        {
            // Если ключ не существует, возвращаем null
            if (key == null) return null;
            // Иначе возвращаем значение ключа по имени
            return key.GetValue(name);
        }
    }

    // Метод для записи значения в реестр по указанному пути и имени ключа
    public static void WriteValue(string path, string name, object value)
    {
        // Открываем или создаем ключ реестра по пути в режиме для записи
        using (RegistryKey key = Registry.LocalMachine.CreateSubKey(path, true))
        {
            // Записываем значение в ключ по имени
            key.SetValue(name, value);
        }
    }
}