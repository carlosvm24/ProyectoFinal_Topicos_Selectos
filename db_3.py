import cx_Oracle
import kivy
from kivy.app import App
#from kivy.uix.gridlayout import GridLayout
from kivy.uix.boxlayout import BoxLayout
from kivy.uix.label import Label
from kivy.uix.textinput import TextInput
from kivy.uix.image import Image
from kivy.config import Config
from kivy.uix.button import Button
from kivy.uix.screenmanager import ScreenManager,Screen


class LoginScreen(BoxLayout,Screen):
    def __init__(self, **kwargs):
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
        self.loginBtn.bind(on_press =self.check_login)
        self.add_widget(self.loginBtn)
    def check_login(self,instance):
        print('Prueba')
        if(self.username.text == 'Gumshoe'):
            print('Gumshoe login')

        sm.current = 'options'

class OptionsScreen(BoxLayout,Screen):
    def __init__(self, **kwargs):
        super(OptionsScreen,self).__init__(**kwargs)
        self.orientation='vertical'
        self.padding = [50, 20, 50, 20]
        self.createButton = Button(text="Create User")
        self.createButton.bind(on_press=self.option_createb)
        self.add_widget(self.createButton)
        self.editButton = Button(text="Edit User")
        self.editButton.bind(on_press=self.option_editb)
        self.add_widget(self.editButton)
        self.delButton = Button(text="Delet This")
        self.delButton.bind(on_press=self.option_delb)
        self.add_widget(self.delButton)
    def option_createb(self,instance):
        print('Prueba Create')
        sm.current = 'createu'
    def option_editb(self,instance):
        print('Prueba Edit')
        sm.current = 'editu'
    def option_delb(self,instance):
        print('Prueba Delete')
        sm.current = 'deleteu'
class CreateUScreen(BoxLayout,Screen):
    def __init__(self, **kwargs):
        super(CreateUScreen, self).__init__(**kwargs)
        self.orientation='vertical'
        self.padding = [50, 20, 50, 20]
        self.add_widget(Label(text='User Name'))
        self.username = TextInput(multiline=False, size_hint_y=None, height=30)
        self.add_widget(self.username)
        self.add_widget(Label(text='Password'))
        self.password = TextInput(password=True, multiline=False, size_hint_y=None, height=30)
        self.add_widget(self.password)
        self.createuButton = Button(text="Create User")
        self.createuButton.bind(on_press=self.createu)
        self.add_widget(self.createuButton)
        self.gobButton = Button(text="Go Back")
        self.gobButton.bind(on_press=self.goback)
        self.add_widget(self.gobButton)
    def createu(self,instace):
        print('Logica crear usuario')
    def goback(self,instance):
        print('Get Back')
        sm.current = 'options'

class EditUScreen(BoxLayout,Screen):
    def __init__(self, **kwargs):
        super(EditUScreen, self).__init__(**kwargs)
        self.orientation = 'vertical'
        self.padding = [50, 20, 50, 20]
        self.add_widget(Label(text='User Name'))
        self.username = TextInput(multiline=False, size_hint_y=None, height=30)
        self.add_widget(self.username)
        self.add_widget(Label(text='Rank'))
        self.password = TextInput(password=True, multiline=False, size_hint_y=None, height=30)
        self.add_widget(self.password)
        self.edituButton = Button(text="Edit User")
        self.edituButton.bind(on_press=self.editu)
        self.add_widget(self.edituButton)
        self.gobButton = Button(text="Go Back")
        self.gobButton.bind(on_press=self.goback)
        self.add_widget(self.gobButton)
    def editu(self,instace):
        print('Logica editar usuario')
    def goback(self,instance):
        print('Get Back')
        sm.current = 'options'

class DeleteUScreen(BoxLayout,Screen):
    def __init__(self, **kwargs):
        super(DeleteUScreen, self).__init__(**kwargs)
        self.orientation = 'vertical'
        self.padding = [50, 20, 50, 20]
        self.image = Image(source='kirbydelet.jpg', size_hint_y=None, height=100)
        self.add_widget(self.image)
        self.add_widget(Label(text='User Name'))
        self.username = TextInput(multiline=False, size_hint_y=None, height=30)
        self.add_widget(self.username)
        self.deleteuButton = Button(text="Delete User")
        self.deleteuButton.bind(on_press=self.deleteu)
        self.add_widget(self.deleteuButton)
        self.gobButton = Button(text="Go Back")
        self.gobButton.bind(on_press=self.goback)
        self.add_widget(self.gobButton)
    def deleteu(self,instace):
        print('Logica borrar usuario')
    def goback(self,instance):
        print('Get Back to where you once belong')
        sm.current = 'options'



Config.set('graphics', 'width', '300')
Config.set('graphics', 'height', '300')
sm = ScreenManager()
sm.add_widget(LoginScreen(name='login'))
sm.add_widget(OptionsScreen(name='options'))
sm.add_widget(CreateUScreen(name='createu'))
sm.add_widget(EditUScreen(name='editu'))
sm.add_widget(DeleteUScreen(name='deleteu'))
global con
con = cx_Oracle.connect('acdp' + '/' + 'proyectodb' + '@' + 'localhost', mode=cx_Oracle.SYSDBA)
print(con.version)

class MyApp(App):

    def build(self):
        self.title = 'TPD: CRIMINAL DB'
        #return LoginScreen()
        return sm


if __name__ == '__main__':
    MyApp().run()
