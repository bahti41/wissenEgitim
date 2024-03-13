import { Button, StyleSheet, Text, View } from 'react-native'
import React, { useState } from 'react'

const Header = (props) => {

    console.log(props)

    const [fullName, setFullName] = useState("Bahtiyar41")

    let name = "Bahtiyar"

    const changeName = () => {
        // console.log('worked')
        // name = "Bahtiyar Sonmez"
        // console.log(name)
        setFullName("Bahtiyar Sönmez")
    }

    return (
        <View>
            <Text>{props.isim}</Text>
            <Text style={styles.name} >{fullName}</Text>
            <Button title="Clict" onPress={changeName} />
        </View>
    )
}

export default Header

const styles = StyleSheet.create({
    name: {
        fontSize: 40,
        color: "red",
        textAlign: "center"
    }
})

