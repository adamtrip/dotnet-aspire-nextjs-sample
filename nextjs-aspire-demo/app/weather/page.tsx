export default async function Home() {
    const apiServer = process.env['services__aspirewithnextjs.webapi__1'];
    const weatherData = await fetch(`${apiServer}/weatherforecast`);
    const res = await weatherData.json();
    return (
        <>
            {JSON.stringify(res)}
        </>
    )
}
