import { Button, StyleSheet, Text, View } from 'react-native'
import React from 'react'
import { NavigationContainer } from '@react-navigation/native'
import { createNativeStackNavigator } from '@react-navigation/native-stack'
import Home from './src/screens/Home'
import Login from './src/screens/Login'
import LoginFormik from './src/screens/LoginFormik'
import Toast from 'react-native-toast-message'
import { Provider } from 'react-redux'
import { store } from './src/store/store'

const Stack = createNativeStackNavigator()

const App = () => {
    return (
        <Provider store={store}>
            <NavigationContainer>
                <Stack.Navigator>
                    <Stack.Screen name='Login' component={LoginFormik} options={{ headerShown: false }} />
                    <Stack.Screen name='Home' component={Home} options={{ headerShown: false }} />
                </Stack.Navigator>
            </NavigationContainer>
            <Toast />
        </Provider>
    )
}

export default App

const styles = StyleSheet.create({})