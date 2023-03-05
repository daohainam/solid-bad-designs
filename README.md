# SOLID-Bad-Designs

Đây là các ví dụ mẫu về năm nguyên tắc có tên SOLID, được dùng khi thiết kế các lớp trong lập trình hướng đối tượng (OOP).
Để dịch và chạy, bạn xem thêm trong phần "Dịch và chạy chương trình" phía dưới.
Năm nguyên tắc này gồm (bạn tham khảo các ví dụ trong từng thư mục tương ứng):

## Single Responsibility
Mỗi lớp chỉ phục vụ cho một mục đích duy nhất.
Lớp ShoppingCart vi phạm nguyên tắc này khi nó vừa là nơi chứa nội dung giỏ hàng, vừa có các chức năng để Load/Save, 
đồng thời có cả chức năng liên quan đến in nội dung giỏ hàng.

Nếu bạn muốn cho phép in ra theo dạng HTML thì sao? Bạn sẽ cần thêm vào một hàm PrintHTML()? Nếu bạn muốn lưu giỏ hàng
theo một cách khác thay vì chuyển thành JSON và lưu vào file? Bạn sẽ cần thêm các hàm để thực hiện việc này. Nếu phát hiện
một lỗi trong Print, bạn cũng sẽ phải dịch và triển khai lại cả các tính năng liên quan đến Load/Save.

Rõ ràng các tính năng Print và Load/Save chẳng liên quan đến nhau về mặt logic, nhưng lại được thiết kế dính chùm. Nếu
nhóm của bạn có hai người riêng biệt phụ trách hai nhóm chức năng trên, họ sẽ phải liên tục merge code của nhau, điều đáng ra 
hoàn toàn có thể tránh được.

Sẽ đơn giản hơn rất nhiều khi bạn thêm các interface như: ICartStorage với các hàm void Save(ShoppingCart)/ShoppingCart Load()...
ICartPrinter với void Print(ShoppingCart) và chuyển các hàm tương ứng sang các lớp con của các interface trên. Vì sao ta tạo 
ra các interface/abstract class rồi implement mà không làm trực tiếp luôn thì bạn có thể xem phần Dependency-Inversion trong 
bài này.

## Open-Closed
Các lớp phải cho phép mở rộng, nhưng không cho phép thay đổi lại các tính năng đã có.

Trong ví dụ này, ta thiết kế lớp Greeting để hiển thị lời chào theo một ngôn ngữ nào đó. Thiết kế này không cho phép ta mở rộng,
bởi không có cách nào thêm một ngôn ngữ mới ngoài việc sửa lại mã nguồn của lớp Greeting cả. Giả sử bạn tạo một lớp con 
có tên GreetingEx thừa kế từ Greeting, thì bạn lại phải sửa enum Languages để thêm một ngôn ngữ mới, và như vậy lại xảy ra vấn đề khác,
đó là khi bạn gọi Greeting.SayHi (không phải GreetingEx.SayHi) với ngôn ngữ mới, Greeting.SayHi sẽ hoạt động sai. 

Đó chỉ là giả sử thôi, thực ra khi thay đổi enum Languages, bạn cũng đã thay đổi Greeting, bởi Greeting nhận vào Languages như
tham số.

Sẽ là hợp lý hơn khi bạn tạo một interface IGreeting như sau:

```csharp
public interface IGreeting
{
    void SayHi();
}
```

Và có các lớp:

```csharp
public class GreetingEn : IGreeting
{
    public void SayHi() {
      Console.WriteLine("Hi!");
    }
}

public class GreetingVi : IGreeting
{
    public void SayHi() {
      Console.WriteLine("Xin chào!");
    }
}
```
Bạn có thể mở rộng ra bao nhiêu ngôn ngữ cũng được mà không cần phải sửa lại mã nguồn của IGreeting.

## Liskov Substitution
Nếu bạn có một con trỏ thuộc lớp cha, thì nó phải hoạt động hoàn toàn đúng đắn khi bạn trỏ nó đến bất kỳ lớp con nào.

## Interface Segregation
Khi thiết kế các interface, mỗi interface sẽ phục vụ cho một mục đích nào đó, đừng tạo các interface kiểu "tất cả trong một".

## Dependency-Inversion
Các lớp chỉ nên phụ thuộc vào các interface, không nên phụ thuộc vào các lớp cụ thể.
