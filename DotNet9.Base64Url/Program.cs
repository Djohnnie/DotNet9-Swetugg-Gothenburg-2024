using System.Buffers.Text;


var data = new byte[32];
Random.Shared.NextBytes(data);

var base64 = Convert.ToBase64String(data);
Console.WriteLine($"Base64: {base64}");

var url64 = Base64Url.EncodeToString(data);
Console.WriteLine($" Url64: {url64}");