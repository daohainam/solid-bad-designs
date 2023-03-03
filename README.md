# SOLID-Bad-Designs

Đây là các ví dụ mẫu về năm nguyên tắc có tên SOLID, được dùng khi thiết kế các lớp trong lập trình hướng đối tượng (OOP).
Để dịch và chạy, bạn xem thêm trong phần "Dịch và chạy chương trình" phía dưới.
Năm nguyên tắc này gồm (bạn tham khảo các ví dụ trong từng thư mục tương ứng):

##Single Responsibility
Mỗi lớp chỉ phục vụ cho một mục đích duy nhất.
Lớp ShoppingCart vi phạm nguyên tắc này khi nó vừa là nơi chứa nội dung giỏ hàng, vừa có các chức năng để Load/Save, 
đồng thời có cả chức năng liên quan đến in nội dung giỏ hàng.
Nếu bạn muốn cho phép in ra theo dạng HTML thì sao? Bạn sẽ cần thêm vào một hàm PrintHTML()? Nếu bạn muốn lưu giỏ hàng
theo một cách khác thay vì chuyển thành JSON và lưu vào file? Bạn sẽ cần thêm các hàm để thực hiện việc này. Nếu phát hiện
một lỗi trong Print, bạn cũng sẽ phải dịch và triển khai lại cả các tính năng liên quan đến Load/Save.
Rõ ràng các tính năng Print và Load/Save chẳng liên quan đến nhau về mặt logic, nhưng lại được thiết kế dính chùm. Nếu
nhóm của bạn có hai người riêng biệt phụ trách hai nhóm chức năng trên, họ sẽ phải liên tục merge code của nhau, điều đáng ra 
hoàn toàn có thể tránh được.

##Open-Closed
Các lớp phải cho phép mở rộng, nhưng không cho phép thay đổi lại các tính năng đã có.

##Liskov Substitution
Nếu bạn có một con trỏ thuộc lớp cha, thì nó phải hoạt động hoàn toàn đúng đắn khi bạn trỏ nó đến bất kỳ lớp con nào.

##Interface Segregation
Khi thiết kế các interface, mỗi interface sẽ phục vụ cho một mục đích nào đó, đừng tạo các interface kiểu "tất cả trong một".

##Dependency-Inversion
Các lớp chỉ nên phụ thuộc vào các interface, không nên phụ thuộc vào các lớp cụ thể.
