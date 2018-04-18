import kivy
from kivy.app import App
#from kivy.uix.gridlayout import GridLayout
from kivy.uix.boxlayout import BoxLayout
from kivy.uix.label import Label
from kivy.uix.textinput import TextInput
from kivy.uix.image import Image
from kivy.config import Config
from kivy.uix.button import Button


class LoginScreen(BoxLayout):
    def __init__(self, **kwargs):
        Config.set('graphics', 'width', '300')
        Config.set('graphics', 'height', '300')
        super(LoginScreen,self).__init__(**kwargs)
        #self.cols = 1
        self.orientation = 'vertical'
        self.padding = [50,0,50,0]
        self.image = Image(source='Policía.png', size_hint_y = None, height = 150)
        self.add_widget(self.image)
        self.add_widget(Label(text='User Name'))
        self.username = TextInput(multiline=False,size_hint_y = None, height = 30)
        self.add_widget(self.username)
        self.add_widget(Label(text='Password'))
        self.password = TextInput(password=True, multiline=False,size_hint_y = None, height = 30)
        self.add_widget(self.password)
        self.loginBtn = Button(text="Login",size_hint_y = None, height = 30)
        self.add_widget(self.loginBtn)


class MyApp(App):

    def build(self):
        self.title = 'TIJUANA POLICE DEPARTMENT: CRIMINAL DATA BASE'
        return LoginScreen()


if __name__ == '__main__':
    MyApp().run()
