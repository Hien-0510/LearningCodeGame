namespace HelloWorld{
    public class WriteFile: Character{

        public void WriteFileMethod(){
            
            string filePath = "Members.json";
            List<Character> characters = new List<Character>();
            
            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    try
                    {
                        characters = System.Text.Json.JsonSerializer.Deserialize<List<Character>>(existingJson) ?? new List<Character>();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi đọc JSON: " + ex.Message);
                    }
                }
                
                // File.AppendAllText(filePath,[]);
                //Input();
                // using (StreamWriter sw = File.AppendText(filePath))
                // {
                //     sw.WriteLine("Id: " + Id);
                //     sw.WriteLine("Name: " + Name);
                //     sw.WriteLine("Exp: " + Exp);
                //     sw.WriteLine("Level: " + Level);
                //     sw.WriteLine("Health: " + MaxHealth);
                //     sw.WriteLine("Mana: " + Mana);
                //     sw.WriteLine("Power: " + Power);
                //     sw.WriteLine("Defense: " + Defense);
                //     sw.WriteLine("Speed: " + Speed);
                //     sw.WriteLine("Skills: " + string.Join(", ", Skills ?? new List<string>()));
                //     sw.WriteLine("Item: " + Item);
                //     sw.WriteLine();
                // }
                //characters.Add(this);
                // var options = new System.Text.Json.JsonSerializerOptions
                // {
                //     WriteIndented = true
                // };
                // string jsonString = System.Text.Json.JsonSerializer.Serialize(this, options);
                // File.WriteAllText(filePath, jsonString);
                // Console.WriteLine("Data written to file successfully.");
            }
                Input();
                characters.Add(this);
                var options = new  System.Text.Json.JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string updatedJson = System.Text.Json.JsonSerializer.Serialize(characters, options);
                File.WriteAllText(filePath, updatedJson);

                Console.WriteLine("Đã lưu nhân vật vào file thành công!");
        }
    }
}