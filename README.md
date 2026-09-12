# Login & Character Selection App

A two-form Windows Forms application in C# that demonstrates user authentication and navigation between forms.

## Features

### Form 1 - Login
- Username and password fields
- Show/Hide password toggle button
- Profile image that can be switched between two images
- Login validation with success/error message boxes
- Navigates to Form 2 upon successful login

### Form 2 - Character Selection
- Displays a title and an image
- Four RadioButtons (Boy, Girl, Book, Pen) that update the image and title dynamically based on selection

## How It Works
- **Login validation**: Checks entered username/password against fixed credentials and shows a `MessageBox` with the result.
- **Password visibility toggle**: Uses the `UseSystemPasswordChar` property to show or hide the password text.
- **Image switching**: A boolean flag (`IsOldImage`) tracks which image is currently displayed and swaps between them on button click.
- **Form navigation**: Uses `Form.Show()` and `Form.Hide()` to move from the login screen to the selection screen without closing the application.

## Tech Stack
- C#
- Windows Forms (.NET Framework)

## What I Learned
- Basic form-to-form navigation (`Show()` / `Hide()`)
- Toggling UI states with boolean flags
- Working with embedded image resources (`Properties.Resources`)
- Awareness of performance considerations when loading images repeatedly from resources

## Known Improvements
- Login credentials are currently hardcoded; could be moved to a config file or database
- Images could be cached in fields instead of being reloaded from `Resources` on every click, to reduce memory allocation
