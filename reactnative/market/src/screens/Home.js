import { Button, FlatList, StyleSheet, Text, View } from 'react-native'
import React, { useEffect, useState } from 'react'
import axios from 'axios'
import CardComponent from '../components/CardComponent'


const Home = () => {

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
            <FlatList
                data={products}
                ListHeaderComponent={
                    <View>
                        <Button title='Get Product' onPress={getData} color={'red'} />
                    </View>
                }
                //horizontal={true} Listeyi yatay hala getirir
                renderItem={({ item }) => <CardComponent item={item} />}
            />
        </View>
    )
}

export default Home

const styles = StyleSheet.create({})