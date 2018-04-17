import kivy
from kivy.app import App
from kivy.uix.gridlayout import GridLayout
from kivy.uix.label import Label
from kivy.uix.textinput import TextInput
from kivy.config import Config
from kivy.uix.button import Button

class LoginScreen(GridLayout):
    def __init__(self, **kwargs):
        Config.set('graphics', 'width', '500')
        Config.set('graphics', 'height', '150')
        super(LoginScreen,self).__init__(**kwargs)
        self.cols = 2
        self.add_widget(Label(text='User Name'))
        self.username = TextInput(multiline=False)
        self.add_widget(self.username)
        self.add_widget(Label(text='password'))
        self.password = TextInput(password=True, multiline=False)
        self.add_widget(self.password)
        self.loginBtn = Button(text="Login")
        self.add_widget(self.loginBtn)

class MyApp(App):

    def build(self):
        self.title = 'TIJUANA POLICE DEPARTMENT: CRIMINAL DATA BASE'
        return LoginScreen()


if __name__ == '__main__':
    MyApp().run()