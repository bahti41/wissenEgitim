import { Button, FlatList, StyleSheet, Text, View } from 'react-native'
import React, { useEffect, useState } from 'react'
import axios from 'axios'

const App = () => {

    const [products, setProducts] = useState([])

    useEffect(() => {
        getData()
    }, [])

    const getData = () => {
        try {
            axios.get("https://dummyjson.com/products").then(res => setProducts(res.data.products))
        } catch (error) {
            console.log('Get Product', error)
        }
    }

    console.log(products)

    return (
        <View>
            <Button title='Get Product' onPress={getData} color={'red'} />
            <FlatList
                data={products}
                renderItem={({ item }) => <Text> {item.title} </Text>}
            />
        </View>
    )
}

export default App

const styles = StyleSheet.create({})


// react native element yüklenecek