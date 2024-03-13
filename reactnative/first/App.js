import { StyleSheet, Text, View } from 'react-native'
import React from 'react'
import Header from './src/components/Header'
import Main from './src/components/Main'
import Footer from './src/components/Footer'

const App = () => {

    let headerText = "Merhaba ben header"
    let mainText = "Merhaba ben main"
    let footerText = "Merhaba ben footer"

    return (
        // <View style={{ backgroundColor: 'blue', height: 500 }}>
        //     <Text style={styles.myText}>App</Text>
        // </View>
        <>
            <Header isim={headerText} />
            <Main mainText={mainText} />
            <Footer footerText={footerText} />
        </>
    )
}

export default App

const styles = StyleSheet.create({})


// porperty: veri aktarımı verittan cayrıta veri aktarımı tek taraflı gönderme