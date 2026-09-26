# CLAUDE CODE SYSTEM INSTRUCTIONS & WORKFLOWS

## I. Global Rules

### 1. Code & Tiêu chuẩn
**Ngôn ngữ**: Communications/docs/comments/commits → Tiếng Việt. Code/biến/file → English.

**Chất lượng**: SOLID, DRY, KISS, YAGNI, Clean Code. Code phải pass compiler, linter, formatter trước khi commit.

**Bảo mật**: Không hardcode secrets. Dùng .env, appsettings.json.

**Validation**: Validate chặt chẽ mọi input (type, range, format, business rules).

**Hiệu năng**: Ưu tiên thư viện chuẩn thay vì tự code thuật toán phổ biến.

**Comment**: Giải thích WHY, không chỉ WHAT. Code tự giải thích thì không cần comment.

**Logging**: DEBUG→INFO→WARN→ERROR. Catch specific exceptions. Error message sạch cho user, log đầy đủ stack trace. Mask sensitive data.

**Dependencies**: Chỉ install khi cần. Pin version cho production.

### 2. Testing
- Viết unit test trong quá trình implement
- AI phải tự động viết test, không chờ được yêu cầu
- Coverage tối thiểu: 90%
- @critical (Path Coverage 100%): Thanh toán, Auth, Validation, Logic phức tạp, Public APIs

### 3. Debug
- Đọc log/test để tìm Root Cause trong codebase
- Không lặp lại giải pháp sai quá 2 lần
- Đổi Plan phải chờ phê duyệt

### 4. Version Control & Task Management
**TaskId**: Jira Issue {PROJECT-NUMBER} (VD: AID-123)
- Branch: {tên nhánh hiện tại}-{taskId}
- Commit: {taskId} - {Nội dung Tiếng Việt}

### 5. Claude Code Rules
**Model Selection:**

| Phase | Model khuyến nghị | Ghi chú |
|-------|-------|---------|
| Xác định taskId | Haiku | Quick check, simple |
| Planning (EnterPlanMode) | Sonnet | Main context, Design & Plan |
| └─ Phase 1 (Context scan) | Haiku (Task/Explore) | Delegate qua Task tool |
| Implementation + Verification | Haiku | Delegate qua Task tool |

User có thể chọn Opus nếu cần (xem escalation flow)

**BẮT BUỘC:** Trước mỗi bước/phase/task, thông báo model THỰC TẾ đang chạy (lấy từ system prompt)
Ví dụ:
  - "Bước 1: Xác định taskId (Haiku)"
  - "Planning Phase - EnterPlanMode (Opus)"
  - "Phase 1: Context scan - Task(Explore, Sonnet)"

---

## II. Workflows (Tuần tự & Bắt buộc)

### Bước 1: Xác định taskId
- Xác định {taskId} từ yêu cầu (format: xem Global Rules)

🛑 **DỪNG NGAY** nếu chưa có {taskId}:
  - Không làm công việc nào khác
  - Yêu cầu user bổ sung {taskId}


### Bước 2: Planning Phase (Plan mode của Claude)

### Bước 3: Implementation + Verification

**BẮT BUỘC:**
  - Git Checkout nhánh mới: `git checkout -b {tên-nhánh-hiện-tại}-{taskId}`

**Execution:**
  - Thực thi theo implementation plan từ Planning Phase

**Verification Loop:**
  - Chạy test: `dotnet test`, `npm test`, `pytest`, etc.
  - **Nếu FAIL:** Đọc log → Sửa lỗi → TodoWrite update → Chạy lại
  - **Đếm tổng số lần fail** (kể cả lỗi khác nhau)

🛑 **DỪNG sau 3 lần fail:**
  - KHÔNG tự tiếp tục fix
  - Báo cáo cho user: lỗi gì, đã fix gì
  - User quyết định: Escalate / Về Planning Phase / Tiếp tục fix
  - Nếu escalate: Hỏi user có muốn chuyển lên Opus không (mặc định Sonnet)


### Bước 4: Finalize
- Tạo summary các thay đổi